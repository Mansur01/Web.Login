using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Login.DAL;
using Web.Login.DTOs;


namespace DALL
{

    public class INFODAL
    {
        private NewDBEntities db = new NewDBEntities();

        public DTO_INFO GetInfoByID(long id)
        {

            TBL_INFO info = new TBL_INFO();

            DTO_INFO dto = new DTO_INFO();
            info.Name = dto.Name;
            return dto;
        }

        public List<DTO_INFO> GetInfoAll()
        {
            //List<DTO_INFO> list = new List<DTO_INFO>();

            //List<TBL_INFO> _list=db.TBL_INFO.ToList();
            ////way 1
            //List<DTO_INFO> list0 = db.TBL_INFO.Select(x => new DTO_INFO() { Name = x.Name, ID = x.ID }).ToList();

            ////way 2
            //_list.ForEach(x => list.Add(new DTO_INFO() { Name = x.Name, ID = x.ID }));

            ////way 3
            //foreach (var info in _list)
            //{
            //    DTO_INFO dt = new DTO_INFO();
            //    dt.Name = info.Name;

            //    list.Add(dt);
            //}
            //return list;

            List<DTO_INFO> list = new List<DTO_INFO>();
            List<TBL_INFO> _list = db.TBL_INFO.ToList();

            foreach(var item in _list)
            {
                DTO_INFO dt = new DTO_INFO();
                item.Name = dt.Name;
                list.Add(dt);
            }

            return list;

            List<DTO_INFO> lisst = db.TBL_INFO.Select(x => new DTO_INFO() { Name = x.Name, Email=x.Email }).ToList();



        }

        public bool Insert(DTO_INFO info)
        {

            TBL_INFO tblinfo = new TBL_INFO();
            tblinfo.Name = info.Name;
            
        }

    }
}
