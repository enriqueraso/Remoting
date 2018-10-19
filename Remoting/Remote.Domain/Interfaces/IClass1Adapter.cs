using Remote.Domain.Entities;

namespace Remote.Domain.Interfaces
{
    public interface IClass1Adapter
    {
        int Sum(int a, int b);
        Class2 Sum2(int a, int b);
        Class2 Sum3(Class2 o, int a);
        
        Class2 CreateClass2();
    }
}