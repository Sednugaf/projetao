namespace projetao.Models
{
    public class HomeModel
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel item;
            List<HomeModel> lista = new List<HomeModel>();

            item = new HomeModel();
            item.id = 1;
            item.name = "Gabriel";
            lista.Add(item);

            return lista;
        }
    }
}