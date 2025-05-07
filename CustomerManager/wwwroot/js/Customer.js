$(document).ready(function () {
    console.log("JS aktif!");
    loadPartial(false);

    $('#statusSwitch').change(function () {
        const showPassive = $(this).is(':checked');
        console.log(showPassive);
        loadPartial(showPassive);
    });

     function loadPartial(showPassive) {
        $.get('/Customer/GetFilteredCustomers', { showPassive: showPassive }, function (html) {
            $('#customerTableContainer').html(html); 

            $('#customerTable').DataTable({
                language: {
                    url: '//cdn.datatables.net/plug-ins/1.13.6/i18n/tr.json' 
                },
                destroy: true,
                "processing": true, 
                "serverSide": false, 
                "paging": true, 
                "searching": true 
            });
        }).fail(function () {
            alert("Veri alınırken bir hata oluştu.");
        });
    }

    $('#addCustomerButton').click(function () {
        $('#customerForm')[0].reset();
        $('#Id').val('');
        $('#addModal').modal('show');
    });

    $('#customerForm').submit(function (e) {
        e.preventDefault();

        var customer = $(this).serialize();
        var id = $('#Id').val();
        var url = id ? '/Customer/Update' : '/Customer/Add';

        $.post(url, customer, function () {
            $('#addModal').modal('hide');

            const showPassive = $('#statusSwitch').is(':checked');
            loadPartial(showPassive);
        }).fail(function () {
            alert("Bir hata oluştu. Lütfen tekrar deneyin.");
        });
    });
    window.editCustomer = function (id) { 
        $.get(`/Customer/Get/${id}`, function (data) {
            $('#Id').val(data.id);
            $('#FirstName').val(data.firstName);
            $('#LastName').val(data.lastName);
            $('#BirthDate').val(data.birthDate.split('T')[0]);
            $('#PhoneNumber').val(data.phoneNumber);
            $('#Email').val(data.email);
            $('#Gender').val(data.gender);
            $('#addModal').modal('show');
        });
    };

    window.deleteCustomer = function (id) { 
        if (confirm('Silmek istediğinize emin misiniz?')) {
            $.post('/Customer/Delete/' + id, function () {
                const showPassive = $('#statusSwitch').is(':checked');
                loadPartial(showPassive); 
            });
        }
    };
});


