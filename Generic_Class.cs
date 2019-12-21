using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Generic_Class<T> where T:BaseEntity{
    public DataContext context;
    public DbSet<T> Model;

    public Generic_Class(DataContext context){
        this.context = context;
        this.Model = context.Set<T>();
    }

    public void addItem(T item){
        Model.Add(item);
    }

    public void Commit(){
        context.SaveChanges();
    }

    public IQueryable<T> Collection(){
        return Model;
    }

    public T findItem(string id){
        T itemtofind = this.Model.Find(id);
        return itemtofind;
    }

    public void Delete(string id){
        T itemtoremove = findItem(id);
        if(context.Entry(itemtoremove).State== EntityState.Deleted){
            Model.Attach(itemtoremove);
        }
        Model.Remove(itemtoremove);
    }

    public void update(string id,T item){
        context.Entry(item).State=EntityState.Modified;
    }
    

}