using GitFresh.Clean.Domain;


namespace GitFresh.Clean.Application
{
    public class DietService : IDietService
    {
        private readonly IDietRepository _dietRepository;
        public DietService(IDietRepository dietRepository)
        {
            _dietRepository = dietRepository;
        }
        public List<Diet> GetAllDiets()
        {
            var diets = _dietRepository.GetAllDiet();
            return diets;
        }
    }
}
