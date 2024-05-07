using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;
public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Zezé",
                    Type = Communication.Enums.PetType.Cat,
                },

                new ResponseShortPetJson
                {
                    Id = 2,
                    Name = "Zara",
                    Type = Communication.Enums.PetType.Dog,
                }
            }
        };
    }
}
