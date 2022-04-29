namespace EventDriven.Arch.Application.Commands.AlterarBeneficiairos;

public record AlterarBeneficiarioCommand(Guid BeneficiarioId, string PrimeiroNome, string SegundoNome) : ICommand
{
    public Guid IntegrationId { get; init; } = Guid.NewGuid();
}