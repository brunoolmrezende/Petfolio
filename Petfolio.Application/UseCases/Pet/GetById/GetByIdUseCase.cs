using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Birthday = new DateTime(year: 2018, month: 07, day: 26),
            Name = "Zezé",
            Type = Communication.Enums.PetType.Bird
        };
    }
}
