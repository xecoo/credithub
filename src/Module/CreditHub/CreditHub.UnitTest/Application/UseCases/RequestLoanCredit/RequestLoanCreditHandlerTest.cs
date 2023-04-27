using Project.Module.CreditHub.Application.UseCases.RequestLoanCredit;
using Shouldly;

namespace Credithub.UnitTest;

public class RequestLoanCreditHandlerTest
{
    [Fact]
    public void Request_loan_credit_is_reproved_when_value_is_over_of_specified()
    {
        
    }

    [Fact]
    public void Request_loan_credit_is_reproved_when_installment_is_less_of_specified()
    {
        
    }

    [Fact]
    public void Request_loan_credit_is_reproved_when_installment_is_over_of_specified()
    {
        
    }

    [Fact]
    public void Request_loan_credit_is_reproved_when_value_is_less_of_specified_for_pj()
    {
        
    }

    [Fact]
    public void Request_loan_credit_is_reproved_when_first_due_date_is_less_of_specified()
    {
        
    }

    [Fact]
    public void Request_loan_credit_is_reproved_when_first_due_date_is_over_of_specified()
    {

    }

    [Fact]
    public async Task Request_loan_credit_is_approved_for_credito_direto_when_filled_the_specifications()
    {
        var request = new RequestLoanCreditRequest(
            1000.00,
            "direto",
            5,
            DateOnly.FromDateTime(DateTime.UtcNow.AddDays(5)).ToString());

        var sut = new RequestLoanCreditHandler();

        var response = await sut.Handle(request, new CancellationToken());

        response.Status.ShouldBe(0);
        response.StatusAsString.ShouldBe("Aprovado");
        response.DebitoTotal.ShouldBe(1020.00);
        response.ValorDoJuros.ShouldBe(2.0);
    }
}             