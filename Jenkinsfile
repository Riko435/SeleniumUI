pipeline  {
  agent any

  stages {
    stage('CleanWorkspace') {
      steps {
        cleanWs()
      }
    }

    stage('Nuget Restore') {
      steps {
        echo "Restore Nuget package"
        sh "dotnet restore"
      }
    }

    stage('Build Tests') {
      steps {
          echo "Build solution"
        sh "dotnet build"
      }
    }

     stage('Run Tests') {
      steps {
        echo "Run UI Tests"
        sh "dotnet test"
      }
    }

    stage('Generate Report') {
      steps {
        allure includeProperties:
                   false,
                     jdk: '',
                     results: [[path: 'build/allure-results']]
      }
    }
  }
}
    
