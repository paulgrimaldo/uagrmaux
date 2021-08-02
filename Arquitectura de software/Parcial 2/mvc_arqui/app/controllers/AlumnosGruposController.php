<?php

class AlumnosGruposController
{

    public function index()
    {
        $alumnos = Alumno::all();
        $grupos = Grupo::all();
        $alumnosGrupos = AlumnoGrupo::all();
        $mensaje = '';
        require_once('../app/views/alumnosGrupos/index.php');
    }

    public function guardar()
    {
        $alumnosGrupos = AlumnoGrupo::all();
        if (isset($_POST['alumnosId']) && isset($_POST['gruposId'])) {
            $alumnosId = $_POST['alumnosId'];
            $gruposId = $_POST['gruposId'];
            for ($i = 0; $i < sizeof($alumnosId); $i++) {
                $alumnoId = $alumnosId[$i];
                $grupoId = $gruposId[$i];

                $save = $this->guardarAlumnoGrupo($alumnoId, $grupoId);
                if (!$save) {
                    $mensaje = 'No se pudo guardar';
                }
            }
            $mensaje = 'Guardo exitoso';
            $alumnosGrupos = AlumnoGrupo::all();
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        $alumnos = Alumno::all();
        $grupos = Grupo::all();
        require_once('../app/views/alumnosGrupos/index.php');
    }

    private function guardarAlumnoGrupo($alumnoId, $grupoId)
    {
        if (count(AlumnoGrupo::exists($alumnoId, $grupoId)) == 0) {
            $model = new AlumnoGrupo(null,$alumnoId, $grupoId);
            return $model->guardar();
        } else {
            return false;
        }
    }
}