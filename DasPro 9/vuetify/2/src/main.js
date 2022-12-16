import Vue from 'vue'
import App from './App.vue'
import router from './router'

import Vuetify from 'vuetify'

Vue.use(Vuetify)

import './assets/main.css'
import 'vuetify/dist/vuetify.min.css'

const app = createApp(App)

app.use(router)

app.mount('#app')
