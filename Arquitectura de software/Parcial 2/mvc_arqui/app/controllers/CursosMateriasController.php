<?php

class CursosMateriasController
{

    public function index()
    {
        $profesores = Profesor::all();
        $cursos = Curso::all();
        $materias = Materia::all();
        $cursosMaterias = CursoMateria::all();
        $mensaje = '';
        require_once('../app/views/cursosMaterias/index.php');
    }

    public function guardar()
    {
        $cursosMaterias = CursoMateria::all();
        if (isset($_POST['cursoId']) && isset($_POST['materiaId']) && isset($_POST['profesorId'])) {
            $cursoId = $_POST['cursoId'];
            $materiaId = $_POST['materiaId'];
            $profesorId = $_POST['profesorId'];

            $model = new CursoMateria(null, (int)$cursoId, (int)$materiaId, (int)$profesorId);
            $save = $model->guardar();
            if ($save) {
                //Agregar un nuevo observable o subject
                $observable = new GrupoTareaSubject($model);
                //Lo agrego al singleton de subjects
                $cms = $_SESSION['cms'];
                if ($cms == null) {
                    $cms = CursosMateriasSubjectsSingleton::getInstance();
                }
                $cms->addCursoMateriaSubject($observable);

                $_SESSION['cms'] = $cms;
                $cursosMaterias = CursoMateria::all();
                $mensaje = 'Guardado correctamente';
            } else {
                $mensaje = 'Error al guardar';
            }
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        $profesores = Profesor::all();
        $cursos = Curso::all();
        $materias = Materia::all();
        require_once('../app/views/cursosMaterias/index.php');
    }
}