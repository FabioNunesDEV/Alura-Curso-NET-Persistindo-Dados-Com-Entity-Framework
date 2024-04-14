using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
internal class DAL<T> where T : class
{
    protected readonly ScreenSoundContext context;

    public DAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> Listar() 
    {
        return context.Set<T>().ToList();
    }
    public void Adicionar(T obj) 
    {
        context.Set<T>().Add(obj);
        context.SaveChanges();
    }
    public void Atualizar(T obj) 
    {
        context.Set<T>().Update(obj);
        context.SaveChanges();
    }
    public void Deletar(T obj)
    {
        context.Set<T>().Remove(obj);   
        context.SaveChanges();
    }

    public T? RecuperarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }

    public IEnumerable<T> ListarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().Where(condicao);
    }


}
