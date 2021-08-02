<?php
require_once('../app/views/template/header.php');
?>
    <div class="row">
        <div class="col-sm-12">
            <div class="card-box">
                <h4 class="m-t-0 header-title"><b>Realizar asignación</b></h4>
                <p class="text-muted m-b-30 font-13"></p>
                <p style="color: #2f24ff"> <?php echo $mensaje; ?></p>
                <div class="row">
                    <form method="post" action="?controller=CursosMaterias&action=guardar">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <label>Materia</label>
                                <select class="custom-select mt-3" id="materiaId" name="materiaId">
                                    <option selected="">Seleccione una materia</option>
                                    <?php foreach ($materias as $materia) { ?>
                                        <option value="<?php echo $materia[0]; ?>"><?php echo $materia[1]; ?></option>
                                    <?php } ?>
                                </select>
                            </div>

                            <div class="form-group">
                                <label>Curso</label>
                                <select class="custom-select mt-3" id="cursoId" name="cursoId">
                                    <option selected="">Seleccione un curso</option>
                                    <?php foreach ($cursos as $curso) { ?>
                                        <option value="<?php echo $curso[0]; ?>"><?php echo $curso[1]; ?></option>
                                    <?php } ?>
                                </select>
                            </div>

                            <div class="form-group">
                                <label>Profesor</label>
                                <select class="custom-select mt-3" id="profesorId" name="profesorId">
                                    <option selected="">Seleccione un profesor</option>
                                    <?php foreach ($profesores as $profesor) { ?>
                                        <option value="<?php echo $profesor[0]; ?>"><?php echo $profesor[1]; ?></option>
                                    <?php } ?>
                                </select>
                            </div>
                        </div>
                        <!-- end col -->
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="m-b-30">
                                    <button id="addToTable" type="submit"
                                            class="btn btn-success waves-effect waves-light">
                                        Guardar<i class="mdi mdi-plus-circle-outline"></i></button>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <!-- end row-->
    <div class="row">
        <div class="col-sm-12">
            <div class="card-box">
                <table class="table table-striped add-edit-table" id="datatable-editable">
                    <thead>
                    <tr>
                        <th>Codigo</th>
                        <th>Codigo Materia</th>
                        <th>Codigo Curso</th>
                        <th>Codigo Profesor</th>
                        <th>Opciones</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    foreach ($cursosMaterias as $cm) { ?>
                        <tr class="gradeX">
                            <td><?php echo $cm[0]; ?></td>
                            <td><?php echo $cm[1]; ?></td>
                            <td><?php echo $cm[2]; ?></td>
                            <td><?php echo $cm[3]; ?></td>
                            <td class="actions">
                                <a href="?controller=CursosMaterias&action=editar&id=<?php echo $cm[0]; ?>"
                                   class="on-default edit-row" data-toggle="tooltip" data-placement="top"><i
                                            class="fa fa-pencil"></i>
                                </a>
                                <a href="?controller=CursosMaterias&action=eliminar&id=<?php echo $cm[0]; ?>"
                                   class="on-default remove-row" data-toggle="tooltip" data-placement="top"><i
                                            class="fa fa-trash-o"></i>
                                </a>
                            </td>
                        </tr>
                    <?php } ?>
                    </tbody>
                </table>
            </div>
        </div>
        <!-- end: page -->
    </div> <!-- end Panel -->

<?php
require_once('../app/views/template/footer.php');
?>