package ar.edu.utn.frc.tup.lciii.Models;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor

public class UserModel {

//    private Long id;
//    @NotEmpty(message = "User Info must not by Empty")
    private String name;

    private String password;

    public UserModel(String name, String password){

        this.name = name;
        this.password = password;
    }

}
