function FecharAlert($scope) {
    $scope.ExibeAlert = false;
    $scope.mensagem = null;
}

function ExibirAlert($scope, mensagem, classe) {
    $scope.ExibeAlert = true;
    $scope.mensagem = mensagem;
    $scope.classe = classe == null ? 'warning' : classe;
}