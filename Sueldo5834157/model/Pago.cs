using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo5834157.model
{
    partial class Pago : ObservableObject
    {
        [ObservableProperty]
        public string sueldo;
        [ObservableProperty]
        public string sueldonuevo;

        [RelayCommand]
        private void SueldoTotal()
        {
            if (decimal.TryParse(sueldo, out decimal dsueldo))
            {
                decimal sueldo = dsueldo < 1000 ? dsueldo * 1.15m : dsueldo * 1.12m;
                Sueldonuevo = sueldo.ToString();


            }
            else
            {
                Sueldonuevo = " por favor ingrese su sueldo del trabajador";
            }

        }
    }
}
