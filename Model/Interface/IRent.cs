using CoreSample.Model.ViewModel;

namespace CoreSample.Model.Interface
{
    public interface IRent 
    {
         Task<List<RentMaster>>  GetAllRenthomes();

             Task<int> AddRentHomes(RentMaster rentMaster);

        int UpdateRentHome(RentMaster rentmaster);
       bool DeleteRentHome(int ID);
     //   Task<List<PatientDetailsMaster>> GetAllPatientDetails2();

    }

    public interface IDept
    {
        Task<List<DeptMaster>> GetAllDepts();

        Task<int> AddDept(DeptMaster deptMaster);


        Task<int> UpdateDept(DeptMaster deptMaster);
        Task<int> DeleteDept(DeptMaster deptMaster);
    }
}
