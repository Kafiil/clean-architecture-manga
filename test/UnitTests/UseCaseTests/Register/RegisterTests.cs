namespace UnitTests.UseCaseTests.Register
{
    using System.Threading.Tasks;
    using Application.Boundaries.Register;
    using Application.UseCases;
    using Presenters;
    using Xunit;

    public sealed class RegisterTests : IClassFixture<StandardFixture>
    {
        private readonly StandardFixture _fixture;
        public RegisterTests(StandardFixture fixture) => this._fixture = fixture;

        [Theory]
        [ClassData(typeof(ValidDataSetup))]
        public async Task Register_WritesOutput_AlreadyRegisterested(decimal amount)
        {
            RegisterPresenterFake presenter = new RegisterPresenterFake();
            const string ssn = "8608178888";

            RegisterUseCase sut = new RegisterUseCase(
                this._fixture.TestUserService,
                this._fixture.CustomerService,
                this._fixture.AccountService,
                this._fixture.SecurityService,
                presenter,
                this._fixture.UnitOfWork,
                this._fixture.CustomerRepositoryFake,
                this._fixture.AccountRepositoryFake);

            await sut.Execute(new RegisterInput(
                ssn,
                amount));

<<<<<<< HEAD
            Assert.NotNull(presenter.AlreadyRegisteredOutput);
=======
            Assert.NotEmpty(presenter.AlreadyRegistered);
>>>>>>> d2070d412d3501455e8c03a82e567114033f6b9f
        }
    }
}
