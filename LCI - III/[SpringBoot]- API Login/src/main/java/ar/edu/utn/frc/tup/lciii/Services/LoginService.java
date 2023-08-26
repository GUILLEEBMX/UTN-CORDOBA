package ar.edu.utn.frc.tup.lciii.Services;

import ar.edu.utn.frc.tup.lciii.Models.UserModel;
import org.springframework.stereotype.Service;

@Service
public interface LoginService {

    boolean login(UserModel user);

}
