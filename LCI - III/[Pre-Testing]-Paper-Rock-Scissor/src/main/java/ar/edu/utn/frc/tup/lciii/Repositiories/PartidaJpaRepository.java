package ar.edu.utn.frc.tup.lciii.Repositiories;

import ar.edu.utn.frc.tup.lciii.entities.PartidaEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface PartidaJpaRepository extends JpaRepository<PartidaEntity, Long> {

    PartidaEntity findByJugadorUno(String jugador);
}
