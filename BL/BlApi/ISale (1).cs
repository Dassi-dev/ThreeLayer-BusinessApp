using BO;

namespace BlApi
{
    public interface ISale:ICrud<Sale>
    {
        public int Create(Sale item); //Creates new entity object in DAL
        public Sale? Read(Func<Sale, bool> filter); // stage 2
        public Sale? Read(int id); //Reads entity object by its ID 
        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null); // stage 2
        public void Update(Sale item); //Updates entity object
        public void Delete(int id); //Deletes an object by its Id
    }
}
