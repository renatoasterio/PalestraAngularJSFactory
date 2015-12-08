app.controller('agendaCtrl', ['$scope', 'agendaFactory', function ($scope, factory) {

    $scope.agendas = [];
    $scope.estados = [];
    $scope.cidades = [];

    factory.ListarEstados(function (data) {
        $scope.estados = data;
    }, function (error) {
        ExibirAlert($scope, error.Message, 'danger')
    });

    $scope.CarregarCidades = function () {
        $scope.cidades = [];
        $scope.Cidade = null;
        if ($scope.Estado != null)
            factory.ListarCidadesPorEstado($scope.Estado.Id, function (data) {
                $scope.cidades = data;
            }, function (error) {
                ExibirAlert($scope, error.Message, 'danger')
            });
    }

    $scope.AdicionarAgenda = function () {
        if ($scope.Evento == null || $scope.Evento == "") {
            ExibirAlert($scope, "Preencha o nome do evento.", 'danger')
            return;
        } else if ($scope.Estado == null) {
            ExibirAlert($scope, "Selecione um Estado");
            return;
        } else if ($scope.Cidade == null) {
            ExibirAlert($scope, "Selecione uma Cidade", 'danger');
            return;
        }

        $scope.agendas.push(
            {
                Id: $scope.agendas.length + 1,
                Nome: $scope.Evento,
                Estado: $scope.Estado.Nome,
                Cidade: $scope.Cidade.Nome
            });

        ExibirAlert($scope, "Agenda Adicionada com Sucesso", 'success');
    }

    $scope.FecharAlert = function () {
        FecharAlert($scope);
    }

}]);