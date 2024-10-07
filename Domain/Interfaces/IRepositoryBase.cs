namespace Domain.Interfaces
{

//Interfaz generica q se usa para trabajar con cualquier
// tipo de dato (O sea T, que representa un tipo generico) 

//la restriccion 'where T : classs' indica que T debe ser una clase
//y no un tipo de dato primitivo (bool, int, etc)
    public interface IRepositoryBase<T> where T : class
    {

        //metodos de la clase
        List<T> GetAll();
        T? GetById<TId>(TId id);
        void Delete(T entity);
        T Update (T entity);
        T Create (T entity);
        
    }
}