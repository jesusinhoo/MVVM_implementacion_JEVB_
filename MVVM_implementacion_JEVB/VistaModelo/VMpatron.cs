using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM_implementacion_JEVB.VistaModelo
{
    internal class VMpatron : BaseViewModel 
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONTRUCTOR

        #endregion
        #region OBJETOS
        
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
    }
}
