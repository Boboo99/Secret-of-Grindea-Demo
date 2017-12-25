using Nutdeep;
using Nutdeep.Exceptions;
using Nutdeep.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretOfGrindeaDemo
{
    public partial class Ui : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public IntPtr RegionSize;
            public uint State;
            public uint Protect;
            public uint Type;
        }

        [DllImport("kernel32.dll")]
        private static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        void Nop(IntPtr adress, int size)
        {
            MemoryEditor editor = new MemoryEditor(cancerGame);

            byte[] nopArray = new byte[3];
            for (int i = 0; i < size; i++)
                nopArray[i] = 0x90;

            //fixing this dirty because Adverti.. didn't fix his code LUUL
            try
            {
                editor.Write<byte[]>(adress, nopArray);
            }
            catch (TypeNotSupportedException) { }
        }

        public Ui()
        {
            InitializeComponent();
        }

        ProcessHandler cancerGame = new ProcessHandler("Secrets Of Grindea");

        private IntPtr _healthAsmLocation = IntPtr.Zero;
        private IntPtr _energyAsmLocation = IntPtr.Zero;
        private IntPtr _bowAmmoAsmLocation = IntPtr.Zero;

        private void GetAdressButton_Click(object sender, EventArgs e)
        {
            var memScanner = new MemoryScanner(cancerGame);
            var healthLocations = memScanner.SearchFor<byte[]>(new byte[] { 0x29, 0x51, 0x34 });
            var energyLocations = memScanner.SearchFor<byte[]>(new byte[] { 0x29, 0x50, 0x40 });
            var bowAmmoLocations = memScanner.SearchFor<byte[]>(new byte[] { 0x29, 0x42, 0x0C });

            IntPtr GetLocation(IntPtr[] locations)
            {
                foreach (var p in locations)
                {
                    MEMORY_BASIC_INFORMATION m;
                    VirtualQueryEx(cancerGame.Handle, p, out m, (uint)Marshal.SizeOf(typeof(MEMORY_BASIC_INFORMATION)));

                    if (m.Protect == 0x00000040) //0x00000040 equals PAGE_EXECUTE_READWRITE
                        return p;
                }

                return IntPtr.Zero;
            }

            if (_healthAsmLocation == IntPtr.Zero) //checking wether this is set already
                _healthAsmLocation = GetLocation(healthLocations); //getting the right asm line's location
            if (_energyAsmLocation == IntPtr.Zero)
                _energyAsmLocation = GetLocation(energyLocations);
            if (_bowAmmoAsmLocation == IntPtr.Zero)
                _bowAmmoAsmLocation = GetLocation(bowAmmoLocations);




            void SetInitialized(IntPtr adress, Label l)
            {
                if (adress == IntPtr.Zero)
                    return;
                l.ForeColor = Color.Green;
                l.Text = "Initialized";
            }

            SetInitialized(_healthAsmLocation, HealthInitzialied);
            SetInitialized(_energyAsmLocation, EnergyInitialized);
            SetInitialized(_bowAmmoAsmLocation, ArrowsInitizialied);

        }

        bool ValidAdressCheck(IntPtr adress, CheckBox box)
        {
            if (adress != IntPtr.Zero)
                return true;
            MessageBox.Show("Change the value atleast once, shoot an array, loose some health or some energy, blame the CLR." + Environment.NewLine + "Repress 'Get Adress' afterwards!");
            box.Checked = false;
            return false;
        }

        void RestoreOriginalBytes(IntPtr adress,byte[] array)
        {
            if(adress != IntPtr.Zero)
            {
                try //fixing adverti.. shitcode smh
                {
                    new MemoryEditor(cancerGame).Write<byte[]>(adress, array);
                }
                catch (TypeNotSupportedException) { }
            }
        }

        private void UnlimitedHealthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UnlimitedHealthCheckBox.Checked)
            {
                if (ValidAdressCheck(_healthAsmLocation, UnlimitedHealthCheckBox)) //checking wether that asm line is initialized
                    Nop(_healthAsmLocation, 3); //replacing that line with code that does nothing
            }
            else
                RestoreOriginalBytes(_healthAsmLocation, new byte[] { 0x29, 0x51, 0x34 });
        }

        private void UnlimitedEnergyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UnlimitedEnergyCheckBox.Checked)
            {
                if (ValidAdressCheck(_energyAsmLocation, UnlimitedEnergyCheckBox))
                    Nop(_energyAsmLocation, 3);
            }
            else
                RestoreOriginalBytes(_energyAsmLocation, new byte[] { 0x29, 0x50, 0x40 });
        }

        private void UnlimitedArrowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UnlimitedArrowsCheckBox.Checked)
            {
                if (ValidAdressCheck(_bowAmmoAsmLocation, UnlimitedArrowsCheckBox))
                    Nop(_bowAmmoAsmLocation, 3);
            }
            else
                RestoreOriginalBytes(_bowAmmoAsmLocation, new byte[] { 0x29, 0x42, 0x0C });
        }
    }
}
