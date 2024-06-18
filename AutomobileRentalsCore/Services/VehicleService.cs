using AutomobileRentalsCore.Models;
using static AutomobileRentalsCore.Contracts.ResourceContracts;
using static AutomobileRentalsCore.Contracts.ServiceContracts;

namespace AutomobileRentalsCore.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleResource _resource;
        public VehicleService(IVehicleResource _resource)
        {
            _resource = _resource;
        }

        public async Task<VehicleModel> GetAsync(int id)
        {
            try
            {
                //todo.. Aunthetication and Authorisation

                var result = await _resource.GetAsync(id);
                return result;
            }
            catch (Exception)
            {
                //todo.. Aunthetication and Authorisation
                throw new Exception("");
            }


        }

        public async Task<VehicleModel> DeleteAsync(VehicleModel model)
        {
            try
            {
                //todo.. Aunthetication and Authorisation

                var canDelete = await onDeleteAsync(model);
                if (!canDelete)
                {
                    //todo.. find a better way to implement this
                    throw new Exception($"Delete disallowed for person with id: {model.veh_id}");
                }

                var canSave = await onSaveAsync(model);

                if (!canSave)
                {
                    throw new Exception($"Delete disallowed for person with id: {model.veh_id}");
                }

                //find a way to imnplement this . (Change Log , Before and After values)
                var result = await _resource.RemoveAsync(model);
                await onDeleteCompletedAsync(model);
                return result;
            }
            catch (Exception)
            {
                throw new Exception("");
            }
        }

        public async Task<bool> DeleteListAsync(int[] id)
        {
            try
            {
                //todo.. Aunthetication and Authorisation 

                var canDelete = await onDeleteListAsync(id);
                if (!canDelete)
                {
                    //todo.. find a better way to implement this
                    throw new Exception($"Delete not allowed for Person id '{string.Join(", ", id)}'.");
                }

                //find a way to imnplement this . (Change Log , Before and After values)
                var result = await _resource.RemoveListAsync(id);
                await onDeleteListCompletedAsync(result);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("");
            }
        }

        public async Task<VehicleModel> PostAync(VehicleModel model)
        {
            try
            {
                //todo.. Aunthetication and Authorisation 

                var canInsert = await onUpdateAsync(model);
                if (!canInsert)
                {
                    //todo.. find a better way to implement this
                    throw new Exception("Insert disallowed for new Person");
                }

                var canSave = await onSaveAsync(model);

                if (!canSave)
                {
                    throw new Exception("Insert disallowed for new Person item");
                }

                var result = await _resource.AddAsync(model);
                await onInsertCompletedAsync(model);
                await onSaveAsync(model);
                return result;
            }
            catch (Exception)
            {
                throw new Exception("");
            }
        }

        public async Task<VehicleModel> PutAsync(VehicleModel model)
        {
            try
            {
                //todo.. Aunthetication and Authorisation 

                var canUpdate = await onUpdateAsync(model);
                if (!canUpdate)
                {
                    //todo.. find a better way to implement this
                    throw new Exception($"Update disallowed for model with id: {model.veh_id}");
                }

                var canSave = await onSaveAsync(model);

                if (!canSave)
                {
                    throw new Exception($"Update disallowed for person with id: {model.veh_id}");
                }

                //find a way to imnplement this . (Change Log , Before and After values)
                var result = await _resource.UpdateAsync(model);
                await onUpdateAsync(model);
                await onSaveAsync(model);
                return result;
            }
            catch (Exception)
            {
                throw new Exception("");
            }
        }

        #region OnEvents

        public Task<bool> onInsertAync(VehicleModel model)
        {
            //input code that must be run before insert to the database is perfomed.
            return Task.FromResult(true);
        }

        public Task<bool> onInsertCompletedAsync(VehicleModel model)
        {
            //input code that must be run after insert to the database is perfomed.
            return Task.FromResult(true);
        }

        public Task<bool> onSaveAsync(VehicleModel model)
        {
            //input code that must be run after data is saved to the database.
            return Task.FromResult(true);
        }

        public Task<bool> onUpdateAsync(VehicleModel model)
        {
            //input code that must be run before updated data is added to the database.
            return Task.FromResult(true);
        }

        public Task<bool> onUpdateCompletedAsync(VehicleModel model)
        {
            //input code that must be run after updated data is added to the database.
            return Task.FromResult(true);
        }

        public Task<bool> onDeleteAsync(VehicleModel model)
        {
            //input code that must be run before data is removed from the database.
            return Task.FromResult(true);
        }

        public Task<bool> onDeleteCompletedAsync(VehicleModel model)
        {
            //input code that must be run after data is removed  to the database.
            return Task.FromResult(true);
        }

        public Task<bool> onDeleteListAsync(int[] id)
        {
            //input code that must be run before list data is removed from the database.
            return Task.FromResult(true);
        }

        public Task<bool> onDeleteListCompletedAsync(VehicleModel[] models)
        {
            //input code that must be run after list data is removed from the database.
            return Task.FromResult(true);
        }

        #endregion
    }
}
