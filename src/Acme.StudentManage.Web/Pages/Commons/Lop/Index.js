$(function () {
    var l = abp.localization.getResource('StudentManage');
    var createModal = new abp.ModalManager(abp.appPath + 'Commons/Lop/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Commons/Lop/EditModal');


    var dataTable = $('#ClassTableLop').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.studentManage.common.lop.getList),
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
                                        acme.studentManage.common.lop
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
                    title: l('note'),
                    data: "note",
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

    $('#insertLop').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});


