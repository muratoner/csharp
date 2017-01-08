using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BenchmarkDotNet.Running;
using Nelibur.ObjectMapper;

namespace MHG.Mapper {
    class Program {
        static void Main( string[] args ) {
            var customerList = new List<Customer>();

            for (var i = 0; i < 10; i++) {
                customerList.Add( new Customer {
                    Address = Faker.Address.SecondaryAddress(),
                    City = Faker.Address.City(),
                    Age = Faker.RandomNumber.Next( 10, 100 ),
                    Name = Faker.Name.First(),
                    Surname = Faker.Name.Last(),
                    Phone = Faker.Phone.Number(),
                    Web = Faker.Internet.DomainName(),
                    Email = Faker.Internet.Email(),
                    Country = Faker.Address.Country()
                } );
            }

            #region Initialize
                #region LightMapper
                    var configListMapper = LightMapper.LightMapper.Instance;
                    configListMapper.AddMapping( configListMapper.CreateMapping<Customer, CustomerDto>( true ) );
                #endregion

                #region AutoMapper
                    var configAutoMapper = new MapperConfiguration( cfg => cfg.CreateMap<Customer, CustomerDto>() );
                    AutoMapper.Mapper.Initialize( cfg => cfg.CreateMap<Customer, CustomerDto>() );
                #endregion

                #region TinyMapper
                    TinyMapper.Bind<Customer, CustomerDto>();
                #endregion

                #region ExpressMapper
                    ExpressMapper.Mapper.Register<Customer, CustomerDto>();
            #endregion
            #endregion

            var customerDtoList = new List<CustomerDto>();

            #region AutoMapper
                var createAutoMapper = configAutoMapper.CreateMapper();
                var dtoAutoMapper = customerList.Select( T => createAutoMapper.Map<CustomerDto>( T ) ).ToList();
            #endregion

            #region LightMapper
                customerDtoList.Clear();
                foreach( var customer in customerList ) {
                    customerDtoList.Add( LightMapper.LightMapper.Instance.Map<Customer, CustomerDto>( customer ) );
                }
            #endregion

            #region TinyMapper
                customerDtoList.Clear();
                foreach( var customer in customerList ) {
                    customerDtoList.Add( TinyMapper.Map<CustomerDto>( customer ) );
                }
            #endregion

            #region TinyMapper
                customerDtoList.Clear();
                foreach( var customer in customerList ) {
                    customerDtoList.Add( ExpressMapper.Mapper.Map<Customer, CustomerDto>( customer ) );
                }
            #endregion

            #region MyCustomMapper
                customerDtoList.Clear();
                foreach( var customer in customerList ) {
                    customerDtoList.Add( customer.Map<Customer, CustomerDto>() );
                }
            #endregion

            #region LinqMapper
                customerDtoList.Clear();
                customerDtoList.AddRange( customerList.Select( T => new CustomerDto {
                    Name = T.Name,
                    Surname = T.Surname
                } ).ToList() );
            #endregion

            #region Benchmarking
                BenchmarkRunner.Run<MapperBenchmarking>();
            #endregion
        }
    }
}
