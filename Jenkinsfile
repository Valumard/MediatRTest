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
    stage('error') {
      parallel {
        stage('error') {
          steps {
            archiveArtifacts(artifacts: 'MediatrTest/bin/**.*', caseSensitive: true, fingerprint: true)
          }
        }
        stage('') {
          steps {
            sh 'docker'
          }
        }
      }
    }
  }
}