﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ws.eng.dao;
using ws.eng.obj;

namespace ws.eng.dll
{
    public class LogradouroDll
    {
        LogradouroDao lgrDao;

        public LogradouroDll()
        {
            lgrDao = new LogradouroDao();
        }

        #region Infra
        public List<LogradouroObj> BuscarMunicipios()
        {
            List<LogradouroObj> obj = new List<LogradouroObj>();
            
            return lgrDao.ListarLogradouro();
        }

        public List<PaisObj> Listar ()
        {
            List<PaisObj> obj = new List<PaisObj>();
            
            return lgrDao.ListarPais();
        }
        #endregion       
        public List<LogradouroObj> BuscarMunicipiosPorCodUF(string CodUF)
        {
            List<LogradouroObj> obj = new List<LogradouroObj>();
           
            return lgrDao.ListarLogradouro();
        }

        public List<LogradouroObj> BuscarMunicipiosPorSiglaUF(string SiglaUF)
        {
            List<LogradouroObj> obj = new List<LogradouroObj>();
           
            return lgrDao.ListarLogradouro();
        }

        public LogradouroObj BuscarMunicipio(string CodMunicipio)
        {
            return lgrDao.ListarLogradouro().Where(x=> x.CodMunicipio == CodMunicipio).FirstOrDefault();
        }
    }
}
