
import './App.css';
import {BrowserRouter, Routes, Route} from 'react-router-dom';
import HomeView from './Views/HomeView';
import ContactsView from './Views/ContactsView';



function App() {
  
  return (
    <BrowserRouter>
   
   <Routes>
     <Route path='/' element={<HomeView/>} />
     <Route path='/contacts' element={<ContactsView/>} /> 

   </Routes>

   </BrowserRouter>
  );
}

export default App;
