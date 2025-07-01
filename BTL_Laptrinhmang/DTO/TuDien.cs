namespace DTO
{
    public class TuDien
    {
        private int id;
        private string ten;
        private string nghia;

        public int Id { get { return id; } set { id = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public string Nghia { get { return nghia; } set { nghia = value; } }

        public TuDien(int id,string ten, string nghia)
        {
            this.id = id;
            this.ten = ten;
            this.nghia = nghia;
        }

    }
}
