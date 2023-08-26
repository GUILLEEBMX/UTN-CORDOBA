package ar.edu.utn.frc.tup.lciii.Repositories;


import ar.edu.utn.frc.tup.lciii.Entities.UserEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

/*
@Component = Se utiliza para marcar una clase como un componente de Spring.
Indica que la clase es un candidato para ser detectado y configurado automáticamente por Spring.

Esta anotación se utiliza para marcar una clase como un componente de acceso a datos.
Indica que la clase se encarga de interactuar con una base de datos o un origen de datos.
 */
@Repository
public interface UserJpaRepository extends JpaRepository<UserEntity, Long> {

}
