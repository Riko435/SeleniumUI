pipeline  {
  ageny any

  stages {
    stage('CleanWorkspace') {
      steps {
        cleanWs()
      }
    }

    stage('Checkout') {
      steps {
            }
    }

    stage('Nuget Restore') {
      steps {
        sh "dotnet restore"
      }
    }

    stage('Build Tests') {
      steps {
        sh "dotnet build"
      }
    }

     stage('Build Tests') {
      steps {
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
    
