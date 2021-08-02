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
                    <form method="post" action="?controller=AlumnosGrupos&action=guardar">
                        <?php for ($i = 0; $i < 5; $i++) { ?>
                            <div class="col-lg-12">
                                <div class="row">
                                    <div class="col-lg-6">
                                        <div class="form-group">
                                            <label>Alumno</label>
                                            <select class="custom-select mt-3" id="alumnosId[]" name="alumnosId[]">
                                                <option selected="" disabled>Seleccione un alumno</option>
                                                <?php foreach ($alumnos as $alumno) { ?>
                                                    <option value="<?php echo $alumno[0]; ?>"><?php echo $alumno[1]; ?></option>
                                                <?php } ?>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-lg-6">
                                        <label>Grupo</label>
                                        <select class="custom-select mt-3" id="gruposId[]" name="gruposId[]">
                                            <option selected="" disabled>Seleccione un grupo</option>
                                            <?php foreach ($grupos as $grupo) { ?>
                                                <option value="<?php echo $grupo[0]; ?>"><?php echo $grupo[1]; ?></option>
                                            <?php } ?>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        <?php } ?>
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
                        <th>Alumno</th>
                        <th>Grupo</th>
                        <th>Opciones</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php
                    foreach ($alumnosGrupos as $ag) { ?>
                        <tr class="gradeX">
                            <td><?php echo $ag[0]; ?></td>
                            <td><?php echo $ag[1]; ?></td>
                            <td><?php echo $ag[2]; ?></td>
                            <td class="actions">
                                <a href="?controller=AlumnosGrupos&action=editar&id=<?php echo $ag[0]; ?>"
                                   class="on-default edit-row" data-toggle="tooltip" data-placement="top"><i
                                            class="fa fa-pencil"></i>
                                </a>
                                <a href="?controller=AlumnosGrupos&action=eliminar&id=<?php echo $ag[0]; ?>"
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