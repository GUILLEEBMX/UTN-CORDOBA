package ar.edu.utn.frc.tup.lciii.Services.Implementation;
import ar.edu.utn.frc.tup.lciii.Models.UserModel;
import ar.edu.utn.frc.tup.lciii.Services.LoginService;
import org.springframework.stereotype.Service;

@Service
public class LoginServiceImplementation implements LoginService {

    @Override
    public boolean login(UserModel user) {

        return user.getName().equals("GUILLERMO") && user.getPassword().equals("ROLLING13.");

    }


}
