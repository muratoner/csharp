using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using Nelibur.ObjectMapper;

namespace MHG.Mapper {
    [HtmlExporter]
    public class MapperBenchmarking {
        [Params( 1, 10, 100, 1000 )]
        public int Param { get; set; }

        private readonly List<Customer> _customerList;
        private readonly MapperConfiguration _config;
        private readonly LightMapper.IMapper _configListMapper;
        public MapperBenchmarking() {
            #region LightMapper
            _configListMapper = LightMapper.LightMapper.Instance;
            _configListMapper.AddMapping( _configListMapper.CreateMapping<Customer, CustomerDto>( true ) );
            #endregion

            #region AutoMapper
            _config = new MapperConfiguration( cfg => cfg.CreateMap<Customer, CustomerDto>() );
            AutoMapper.Mapper.Initialize( cfg => cfg.CreateMap<Customer, CustomerDto>() );
            #endregion

            #region TinyMapper
            TinyMapper.Bind<Customer, CustomerDto>();
            #endregion

            #region ExpressMapper
            ExpressMapper.Mapper.Register<Customer, CustomerDto>();
            #endregion

            _customerList = new List<Customer>();
        }

        [Setup]
        public void Setup() {
            for( int i = 0; i < Param; i++ ) {
                _customerList.Add( new Customer {
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
        }

        [Benchmark]
        public void AutoMapperBenchmark() {
            var customerDtoList = new List<CustomerDto>();
            var config = _config.CreateMapper();
            foreach( var customer in _customerList ) {
                customerDtoList.Add( config.Map<CustomerDto>( customer ));
            }
        }

        [Benchmark]
        public void WithLinqBenchmark() {
            var dtoLinq = _customerList.Select( T => new CustomerDto {
                Name = T.Name,
                Surname = T.Surname
            } ).ToArray();
        }

        [Benchmark]
        public void LightMapperBenchmark() {
            var customerDtoList = new List<CustomerDto>();
            foreach( var customer in _customerList ) {
                customerDtoList.Add( LightMapper.LightMapper.Instance.Map<Customer, CustomerDto>( customer ) );
            }
        }

        [Benchmark]
        public void MyCustomMapperBenchmark() {
            var customerDtoList = new List<CustomerDto>();
            foreach( var customer in _customerList ) {
                customerDtoList.Add( customer.Map<Customer, CustomerDto>() );
            }
        }

        [Benchmark]
        public void TinyMapperBenchmark() {
            var customerDtoList = new List<CustomerDto>();
            foreach( var customer in _customerList ) {
                customerDtoList.Add( TinyMapper.Map<CustomerDto>( customer ) );
            }
        }

        [Benchmark]
        public void ExpressMapperBencmark() {
            var customerDtoList = new List<CustomerDto>();
            foreach( var customer in _customerList ) {
                customerDtoList.Add( ExpressMapper.Mapper.Map<Customer, CustomerDto>( customer ) );
            }
        }
    }
}
