import { Home } from "./components/Home";
import UserProfileView from "./user/UserProfile";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/userprofile',
    element: <UserProfileView />
  },
  {
    path: '/blog',
    element: <FetchData />
  }
];

export default AppRoutes;
