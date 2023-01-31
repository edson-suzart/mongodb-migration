using MongoDbMigration.Interfaces;

namespace MongoDbMigration.Factory
{
    public class Factory : IFactory
    {
        private readonly ICarInterface _carInterface;
        private readonly IPersonInterface _personInterface;

        public Factory(ICarInterface carInterface, IPersonInterface personInterface)
        {
            _carInterface = carInterface;
            _personInterface = personInterface;
        }

        public ICarInterface GetCarInstance() => _carInterface;

        public IPersonInterface GetPersonInstance() => _personInterface;
    }
}
