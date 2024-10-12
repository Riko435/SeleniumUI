pipeline  {
  agent any

  stages {
    stage('CleanWorkspace') {
      steps {
        cleanWs()
      }
    }

    stage('Checkout') {
      steps {
          git 'https://github.com/Riko435/SeleniumUI.git'
      }
    }

    stage('Nuget Restore') {
      steps {
        echo "Restore Nuget package"
        bat 'dotnet restore TestProject1.sln'
      }
    }

     stage('Run Tests') {
      steps {
        echo "Run UI Tests"
        bat 'dotnet test TestProject1.sln'
      }

      post {
        allure(
          [
            allure includeProperties:
                     false,
                     jdk: '',
                     reportBuildPolicy: 'ALWAYS',
                     results: [[path: 'target/allure-results']]
          ])
      }
    }
  }
}
  