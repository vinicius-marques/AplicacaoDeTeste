var app = angular.module("aplicacaoTeste", []);

app.controller("ctrlCliente", function ($scope, $http) {

    $scope.listaDeClientes = [];

    CarregaClientes();

    function CarregaClientes() {

        $http.get(clienteApi)
            .then(function (data) {
            
                $scope.listaDeClientes = data;

            }, function (error) {

            });
    }

});



