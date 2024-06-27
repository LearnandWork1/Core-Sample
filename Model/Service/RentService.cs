using CoreSample.Model.Interface;
using CoreSample.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreSample.Model.Service
{
    public class RentService : IRent
    {
        //public RentService() { }

        private readonly rentDBContext _context;

        public RentService(rentDBContext context)
        {

            _context = context;
        }

        //  [HttpGet(Name = "GetAllRentHomes")]
        public async Task<List<RentMaster>> GetAllRenthomes()
        {
            try
            {
                var rentsList = await _context.rentMasters.ToListAsync();
                return rentsList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<PatientDetailsMaster>> GetAllPatientDetails2()
        {
            try
            {
                var PatientDetailsList = await _context.patientDetailsMasters.ToListAsync();
                return PatientDetailsList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<int> AddRentHomes(RentMaster rentmaster)
        {
            try
            {
                _context.rentMasters.Add(rentmaster);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int UpdateRentHomeAll(RentMaster rentmaster)
        {
            try
            {
                _context.Entry(rentmaster).State = EntityState.Modified;
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public RentMaster UpdateRentHome2(RentMaster rentmaster)
        {
            try
            {
              var record=_context.rentMasters.Single(R=>R.RentID==rentmaster.RentID);
                record.Name=rentmaster.Name;
                record.LandMark=rentmaster.LandMark;
                record.HomeType=rentmaster.HomeType;
                record.Location=rentmaster.Location;
                record.HomeType=record.HomeType;

                _context.SaveChanges(); 
                return record;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int UpdateRentHome(RentMaster rentmaster)
        {
            try
            {
                var record = _context.rentMasters.Single(R => R.RentID == rentmaster.RentID);
                record.Name = rentmaster.Name;
                record.LandMark = rentmaster.LandMark;
                record.HomeType = rentmaster.HomeType;
                record.Location = rentmaster.Location;
                record.HomeType = record.HomeType;

                _context.SaveChanges();
                return record.RentID;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool DeleteRentHome(int ID)
        {
            try
            {
                var rentMaster = _context.rentMasters.Single(d => d.RentID == ID);
                _context.rentMasters.Remove(rentMaster);
                //_context.rentMasters.ExecuteDelete();
                _context.SaveChanges(true);

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }




    public class DeptService : IDept
    {
        //public RentService() { }

        private readonly rentDBContext _context;

        public DeptService(rentDBContext context)
        {
            _context = context;
        }

        //  [HttpGet(Name = "GetAllRentHomes")]
        public async Task<List<DeptMaster>> GetAllDepts()
        {
            try
            {
                var deptsList = await _context.deptMasters.ToListAsync();
                return deptsList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<int> AddDept(DeptMaster deptmaster)
        {
            try
            {
                _context.deptMasters.Add(deptmaster);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<int> UpdateDept(DeptMaster deptmaster)
        {
            try
            {
                //_context.Entry(obj).State EntityState.Modified;
                //_context.SaveChanges();
                //return obj;


                _context.deptMasters.Update(deptmaster);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public async Task<int> DeleteDept(DeptMaster deptmaster)
        {
            try
            {
                _context.deptMasters.ExecuteDelete();
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
