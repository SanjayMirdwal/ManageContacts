using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MVCDBFirstAutoMapper.Data;
using MVCDBFirstAutoMapper.Business.ModelEntity;

namespace MVCDBFirstAutoMapper.Business
{
    /// <summary>
    /// This class performs mapping between Business objects and DataBase Entities.
    /// </summary>
    public class CustomMapping
    {
        private static CustomMapping _instance = null;
        private static object _lock = new object();
        public IMapper _Mapper = null;
        private CustomMapping() { }

        public IMapper Mapper
        {
            get { return _Mapper; }
            set { _Mapper = value; }
        }

        /// This method create single instance of this class and returns the same instance in the subsequent class.
        public static CustomMapping GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new CustomMapping();
                    _instance.RegisterMappings();
                }
                return _instance;
            }
        }

        public void RegisterMappings()
        {
            // Here you have to register all the mapping of Entity and DTO..
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<Users, UsersDTO>()
                cfg.CreateMap<Contact, ContactDTO>();

                // If you wish to structurised and register all realated entity at seperate place then write method and call here llike that.
                //RegisterUsersDTO(cfg);
            });

            _Mapper = config.CreateMapper();
        }

        public static void RegisterUsersDTO(IMapperConfigurationExpression config)
        {
            config.CreateMap<Contact, ContactDTO>();
        }
    }
}
