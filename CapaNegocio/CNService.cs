using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNService
    {
        CDService cDService = new CDService();

        #region CREATE SERVICE
        public bool CreateService(CEService cE)
        {
            return cDService.AddService(cE);
        }
        #endregion

        #region DeleteService
        public bool DeleteService(CEService service)
        {
            return cDService.DeleteService(service);
        }

        #endregion

        #region UpdateService
        public bool UpdateService(CEService service)
        {
            return cDService.UpdateService(service);
        }
        #endregion

        #region ListService
        public List<CEService> ListALLService()
        {
            return cDService.ListALLService();
        }
        #endregion

        #region ListTipeService
        public List<CETipoServicio> ListALLtipeService()
        {
            return cDService.ListALLSys_TIPOSERVICIO();
        }
        #endregion

        
    }
}
