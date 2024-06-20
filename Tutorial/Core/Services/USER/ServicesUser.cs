using AutoMapper;
using Domain;

namespace Core;
public class ServicesUser : IServicesUser
{
    private readonly IUserRepository userRepository;
    private readonly IMapper mapper;

    public ServicesUser(IUserRepository userRepository, IMapper mapper)
    {
        this.userRepository = userRepository;
        this.mapper = mapper;
    }

    public async Task<List<userResponse>?> getAllUser()
    {
        var data = await userRepository.GetAsync();
        return await Task.FromResult(mapper.Map<List<userResponse>>(data));
    }

    public async Task<userResponse?> getUserByID(int id)
    {
        var data = await userRepository.GetByIdAsync(id);
        return await Task.FromResult(mapper.Map<userResponse>(data));
    }
    public async Task<userResponse?> getUserByUsername(string username)
    {
        var data = await userRepository.GetByUsernameAsync(username);
        return await Task.FromResult(mapper.Map<userResponse>(data));
    }

    public async Task<userResponse?> createUser(string username, string password)
    {
        var data = new userResponse
        {
            username = username.ToLower(),
            password = password,
            CreatedBy = "SYSTEM",
            UpdatedBy = "SYSTEM",
        };

        var checkIsAlreadyUsername = await (userRepository.DoesExist(x => x.username == data.username));
        if (checkIsAlreadyUsername)
            throw new Exception("ไม่สามารถเพิ่มผู้ใช้งานได้ เนื่องจากมี username นี้ในระบบแล้ว");

        var model = await userRepository.AddAsync(mapper.Map<User>(data));
        await userRepository.SaveChangesAsync();

        return await Task.FromResult<userResponse?>(mapper.Map<userResponse>(model));
    }

    public async Task updatePasswordByID(int id, string password)
    {
        var checkIsAlreadyUsername = await (userRepository.DoesExist(x => x.Id == id));
        if (!checkIsAlreadyUsername)
            throw new Exception("ไม่พบผู้ใช้งานที่ต้องการเปลี่ยนรหัสผ่าน");

        var model = await userRepository.GetByIdAsync(id);

        if (model == null)
            throw new Exception("ไม่พบผู้ใช้งานที่ต้องการเปลี่ยนรหัสผ่าน");
        model.password = password;
        userRepository.Update(model);
        await userRepository.SaveChangesAsync();

        await Task.CompletedTask;
    }
    public async Task updatePasswordByUsername(string username, string password)
    {
        var checkIsAlreadyUsername = await (userRepository.DoesExist(x => x.username == username.ToLower()));
        if (!checkIsAlreadyUsername)
            throw new Exception("ไม่พบผู้ใช้งานที่ต้องการเปลี่ยนรหัสผ่าน");

        var model = await userRepository.GetByUsernameAsync(username.ToLower());

        if (model == null)
            throw new Exception("ไม่พบผู้ใช้งานที่ต้องการเปลี่ยนรหัสผ่าน");
        model.password = password;
        userRepository.Update(model);
        await userRepository.SaveChangesAsync();

        await Task.CompletedTask;
    }
}