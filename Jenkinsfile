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
    }
stage('Generate Allure Report') { steps { script { ws('/C:/ProgramData/Jenkins/.jenkins/workspace/UITests_master/TestProject1/bin/Debug/net8.0/') { allure([ includeProperties: false, jdk: '', properties: [], reportBuildPolicy: 'ALWAYS', results: [[path: 'allure-results']] ]) } } } }

  }
}
  