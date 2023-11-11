// Classe fake para o IAccountService
public class AccountServiceFake : IAccountService
{
    public async Task<UserDto> GetUserByUserNameAsync(string userName)
    {
        // Implemente aqui a lógica fake para retornar um usuário fictício
        return new UserDto { UserName = userName, PrimeiroNome = "John", Token = "fake-token" };
    }

    public async Task<bool> UserExists(string userName)
    {
        // Implemente aqui a lógica fake para verificar se um usuário existe
        return false;
    }

    public async Task<UserDto> CreateAccountAsync(UserDto userDto)
    {
        // Implemente aqui a lógica fake para criar uma conta de usuário
        return new UserDto { UserName = userDto.UserName, PrimeiroNome = userDto.PrimeiroNome, Token = "fake-token" };
    }

    public async Task<UserDto> CheckUserPasswordAsync(UserDto userDto, string password)
    {
        // Implemente aqui a lógica fake para verificar a senha do usuário
        if (password == "fake-password")
        {
            return userDto;
        }
        return null;
    }

    public async Task<UserDto> UpdateAccount(UserUpdateDto userUpdateDto)
    {
        // Implemente aqui a lógica fake para atualizar a conta do usuário
        return new UserDto { UserName = userUpdateDto.UserName, PrimeiroNome = userUpdateDto.PrimeiroNome, Token = "fake-token" };
    }
}

// Classe fake para o ITokenService
public class TokenServiceFake : ITokenService
{
    public async Task<string> CreateToken(UserDto userDto)
    {
        // Implemente aqui a lógica fake para criar um token
        return "fake-token";
    }
}

// Classe fake para o IUtil
public class UtilFake : IUtil
{
    public string SaveImage(IFormFile file, string destino)
    {
        // Implemente aqui a lógica fake para salvar uma imagem
        return "fake-image-url";
    }

    public void DeleteImage(string imageUrl, string destino)
    {
        // Implemente aqui a lógica fake para excluir uma imagem
    }
}
