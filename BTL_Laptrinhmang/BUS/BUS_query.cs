using DAL ;
using System.Data;
namespace BUS
{
    public class BUS_query 
    {
        Query query = new Query();
        public bool Them(string tu, string yNghia)
        {
            return query.Them(tu, yNghia);
        }
        public DataTable Hienthi()
        {
            return query.hienThi();
        }
        public bool Sua(int id, string tu, string ynghia)
        {
            return query.sua(id,tu,ynghia);
        }
        public bool Xoa(int id)
        {
             return query.xoa(id); 
        }
        public DataTable Timkiem(string tu)
        {
            return query.Timkiem(tu);
        }
        public List<string> danhsach(string a)
        {
            return query.Danhsach(a);
        }
    }
}
