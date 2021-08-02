<?php

class AlumnoGrupoTarea extends AbstractModel
{
    public $id;
    public $alumnoGrupoId;
    public $tareaId;
    public $calificacion;
    public $parteTarea;

    public function __construct($id, $alumnoGrupoId, $tareaId, $calificacion, $parteTarea)
    {
        $this->id = $id;
        $this->alumnoGrupoId = $alumnoGrupoId;
        $this->tareaId = $tareaId;
        $this->calificacion = $calificacion;
        $this->parteTarea = $parteTarea;
    }

    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO alumnos_grupos_tareas (alumno_grupo_id,tarea_id,calificacion,parte_tarea) values(?,?,?,?)");
        $sql->bindParam(1, $this->alumnoGrupoId, PDO::PARAM_INT);
        $sql->bindParam(2, $this->tareaId, PDO::PARAM_INT);
        $sql->bindParam(3, $this->calificacion, PDO::PARAM_INT);
        $sql->bindParam(4, $this->parteTarea, PDO::PARAM_STR, 255);

        return $sql;
    }

    public function setModelId()
    {
        $db = Db::getInstance();
        $this->id = $db->lastInsertId();
    }

    public static function exists($alumnoGrupoId, $tareaId)
    {
        $db = Db::getInstance();
        $sql = 'SELECT * FROM alumnos_grupos_tareas WHERE alumno_grupo_id="' . $alumnoGrupoId . '" and tarea_id="' . $tareaId . '"';
        $req = $db->query($sql);
        return $req->fetchAll();
    }

    public static function all()
    {
        $db = DB::getInstance();
        $req = $db->query('SELECT agt.id, t.nombre, a.nombre,g.nombre,agt.calificacion,agt.parte_tarea FROM alumnos_grupos_tareas agt  
join tareas t on t.id=agt.tarea_id join alumnos_grupos ag on ag.id=agt.alumno_grupo_id join alumnos a on a.id = ag.alumno_id 
join grupos g on g.id = ag.grupo_id');
        return $req->fetchAll();
    }
}