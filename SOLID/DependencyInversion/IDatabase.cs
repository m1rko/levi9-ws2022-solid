namespace SOLID.DependencyInversion
{
    public interface IDatabase
    {
        public void Insert();
        public void Update();
        public void Delete();
    }
}
