using BackEnd.Interface.Specialized;
using BackEnd.Entity;

namespace BackEnd.Interface.Base;

public interface IActivity : IAuth, IEvaluable, ICommitable, IRetrievable<EmployeeActivity>{
    void SetEntrance();
    void SetExit();
}
