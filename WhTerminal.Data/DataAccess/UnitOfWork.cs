using System;
using WhTerminal.Data.Models;

namespace WhTerminal.Data.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private WhContext context = new WhContext();
        private GenericRepository<Area> areaRepository;
        private GenericRepository<Hangar> hangarRepository;
        private GenericRepository<Warehouse> warehouseRepository;
        private GenericRepository<Container> containerRepository;
        public GenericRepository<Area> AreaRepository
        {
            get
            {

                if (this.areaRepository == null)
                {
                    this.areaRepository = new GenericRepository<Area>(context);
                }
                return areaRepository;
            }
        }

        public GenericRepository<Hangar> HangarRepository
        {
            get
            {

                if (this.hangarRepository == null)
                {
                    this.hangarRepository = new GenericRepository<Hangar>(context);
                }
                return hangarRepository;
            }
        }
        public GenericRepository<Warehouse> WarehouseRepository
        {
            get
            {

                if (this.warehouseRepository == null)
                {
                    this.warehouseRepository = new GenericRepository<Warehouse>(context);
                }
                return warehouseRepository;
            }
        }

        public GenericRepository<Container> ContainerRepository
        {
            get
            {

                if (this.containerRepository == null)
                {
                    this.containerRepository = new GenericRepository<Container>(context);
                }
                return containerRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
