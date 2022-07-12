$(function () {
    var l = abp.localization.getResource('StudentManage');
    var createModal = new abp.ModalManager(abp.appPath + 'Commons/SinhVien/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Commons/SinhVien/EditModal');


    var dataTable = $('#ClassTableSinhVien').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.studentManage.common.sinhVien.getList),
            columnDefs: [

                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l('Bạn có muốn xóa file này ?', data.record.name);
                                    },
                                    action: function (data) {
                                        acme.studentManage.common.sinhVien
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]


                    }
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Tuoi'),
                    data: "age",


                },
                {
                    title: l('Lop'),
                    data: "lopId",
                },
                {
                    title: l('CMND'),
                    data: "cmnd",
                },
                
                
                
            ]
        })
    );


    createModal.onResult(function () {

        dataTable.ajax.reload();
    });
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#insertSinhVien').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});


