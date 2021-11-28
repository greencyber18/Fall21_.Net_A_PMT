app.controller("Project",function($scope,$http){
    $http.get("https://localhost:44320/api/Project/All").
    then(function(resp){
        $scope.Project= resp.data;
    });
});
