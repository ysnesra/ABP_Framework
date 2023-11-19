$(function () {

    var l = abp.localization.getResource('OurService');

    console.log(l);

    var dataTable = $('#OurServicesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(mcApp.ourService.getList),
            columnDefs: [
                {
                    title: l('Name'),
                    data: "name"
                },
               
                {
                    title: l('Price'),
                    data: "priceOf"
                }
                
            ]
        })
    );
});
