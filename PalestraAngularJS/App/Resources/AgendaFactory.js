app.factory('agendaFactory', ['$http', 'apiInfo', function ($http, apiInfo) {

    var _listarEstados = function (callbackSuccess, callbackError) {
        $http.get(apiInfo.Url + 'ListarEstados').success(callbackSuccess).error(callbackError);
    }

    var _listarCidadesPorEstado = function (idEstado, callbackSuccess, callbackError) {
        $http.get(apiInfo.Url + 'ListarCidadePorUF?idEstado=' + idEstado)
            .success(callbackSuccess).error(callbackError);
    }


    return {
        ListarEstados: _listarEstados,
        ListarCidadesPorEstado: _listarCidadesPorEstado
    };


}]);