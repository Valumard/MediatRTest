pipeline {
  agent any
  stages {
    stage('Restore') {
      steps {
        sh 'dotnet restore'
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet build'
      }
    }
    stage('') {
      steps {
        archiveArtifacts(artifacts: 'MediatrTest/bin', caseSensitive: true, fingerprint: true)
      }
    }
  }
}